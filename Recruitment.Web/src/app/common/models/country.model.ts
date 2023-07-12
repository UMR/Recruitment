export interface CountryModel {
    countryId: number;
    countryName: string;
    description: string;
    createdBy: number | null;
    createdDate: Date | null;
    updatedBy: number | null;
    updatedDate: Date | null;
}