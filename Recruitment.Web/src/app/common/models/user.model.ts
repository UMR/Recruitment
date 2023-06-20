export interface User {
    userId: number;
    loginId: string;
    firstName: string;
    lastName: string;
    password: string;
    email: string;
    telephone: string;
    odapermission: boolean;
    isActive: boolean;
    createdBy: number;
    createdDate: Date;
    updatedBy: number;
    updatedDate: Date;
    timeOut: number;
    agencyId: number;
}