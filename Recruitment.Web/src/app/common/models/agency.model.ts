export interface AgencyModel {
    agencyId: number;
    agencyName: string;
    agencyAddress: string;
    uRLPrefix: string;
    agencyEmail: string;
    agencyPhone: string;
    agencyContactPerson: string;
    agencyContactPersonPhone: string;
    isActive: boolean;
    agencyLoginId: string;
    createdBy: number;
    createdDate: Date;
    updatedBy: number;
    updatedDate: Date;
}