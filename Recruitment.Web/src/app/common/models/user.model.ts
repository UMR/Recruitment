export interface User {
    userId: number;
    LoginId: string;
    FirstName: string;
    LastName: string;
    Password: string;
    Email: string;
    Telephone: string;
    Odapermission: boolean;
    IsActive: boolean;
    CreatedBy: number;
    CreatedDate: Date;
    UpdatedBy: number;
    UpdatedDate: Date;
    TimeOut: number;
    AgencyId: number;
}