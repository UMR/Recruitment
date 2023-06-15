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
    public visibleAddEditInstitutionTypeDialog: boolean = false;

    constructor(private messageService: MessageService, private confirmationService: ConfirmationService,
        private institutionTypeService: InstitutionTypeService) { }

    ngOnInit(): void {
        this.getInstitutionTypes();
    }

   addInstitutionType(): void {
       this.visibleAddEditInstitutionTypeDialog = true;
    }

    editInstitutionType() {
        this.visibleAddEditInstitutionTypeDialog = true;
    }

    saveInstitutionType(): void {
        this.visibleAddEditInstitutionTypeDialog = false;
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
