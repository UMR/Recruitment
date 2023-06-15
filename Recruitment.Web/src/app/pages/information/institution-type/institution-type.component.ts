import { Component } from '@angular/core';
import { ConfirmationService, MessageService } from 'primeng/api';
import { InstitutionTypeService } from './institution-type.service';

@Component({
  selector: 'app-institution-type',
  templateUrl: './institution-type.component.html',
  styleUrls: ['./institution-type.component.scss']
})
export class InstitutionTypeComponent {

    public institutionTypes: any[] = [];
    public institutionTypeDialog: boolean = false;
    public addEditTxt = "Add";
    public submitted = false;

    constructor(private messageService: MessageService, private confirmationService: ConfirmationService,
        private institutionTypeService: InstitutionTypeService) { }

    ngOnInit(): void {
        this.getInstitutionTypes();
    }

   addInstitutionType(): void {
       this.institutionTypeDialog = true;
    }

    editInstitutionType() {
        this.institutionTypeDialog = true;
    }

    saveInstitutionType(): void {
        this.institutionTypeDialog = false;
    }

    hideAddEditDialog() {
        this.institutionTypeDialog = false;
        this.submitted = false;
    }

    getInstitutionTypes() {
        this.institutionTypeService.getInstitutionTypes().subscribe({
            next: (res) => {                
                this.institutionTypes = res.body;
                console.log(this.institutionTypes);
            },
            error: (err) => {
                console.log(err);
            },
            complete: () => {
            }
        });
    }
}
