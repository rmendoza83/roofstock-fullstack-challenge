import { Component, OnInit } from '@angular/core';
import { PropertyModel } from 'src/app/models/property.model';
import { DataService } from '../../services/data.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent implements OnInit {
  properties: PropertyModel[] = [];
  loading: boolean = false;

  constructor(private dataService: DataService) { }

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

        } else {

        }
        this.loading = false;
      });
  }
}
