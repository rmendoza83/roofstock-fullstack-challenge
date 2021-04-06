import { Component, OnInit } from '@angular/core';
import { MessageService } from 'primeng/api';

import { PropertyModel } from '../../models/property.model';
import { DataService } from '../../services/data.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent implements OnInit {
  properties: PropertyModel[] = [];
  loading: boolean = false;

  constructor(private dataService: DataService,
    private messageService: MessageService) { }

  ngOnInit() {
    this.dataService.getList()
      .subscribe(response => {
        if (response.Success) {
          this.properties = response.Properties;
          console.log(this.properties);
        }
      });
  }

  saveProperty(row: PropertyModel) {
    this.loading = true;
    this.dataService.postProperty(row)
      .subscribe(response => {
        if (response.Success) {
          this.sendSuccessMessage();
        } else {
          this.sendErrorMessage(response.ErrorMessage);
        }
        this.loading = false;
      });
  }

  private sendSuccessMessage() {
    this.messageService.add({
      severity: 'success',
      summary: 'Success',
      detail: 'The Property has been saved into the database'
    });
  }

  private sendErrorMessage(errorMessage: string) {
    this.messageService.add({
      severity: 'error',
      summary: 'Error',
      detail: errorMessage
    });
  }
}
