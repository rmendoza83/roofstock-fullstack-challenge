class AddressModel {
  public address1: string;
  public address2: string;
  public city: string;
  public country: string;
}

class PhysicalModel {
  public yearBuilt: number;
}

class FinancialModel {
  public listPrice: number;
  public monthlyRent: number;
}

export class PropertyRawModel {
  public id: number;
  public address: AddressModel;
  public financial: FinancialModel;
  public physical: PhysicalModel;
}