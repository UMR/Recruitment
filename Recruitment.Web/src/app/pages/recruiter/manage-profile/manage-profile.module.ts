import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ManageProfileRoutingModule } from './manage-profile-routing.module';
import { ManageProfileComponent } from './manage-profile.component';
import { CardModule } from 'primeng/card';
import { PasswordModule } from 'primeng/password';
import { ButtonModule } from 'primeng/button';
import { FormsModule } from '@angular/forms';
import { DropdownModule } from 'primeng/dropdown';
import { InputMaskModule } from 'primeng/inputmask';
import { MessageService } from 'primeng/api';
import { LoaderModule } from '../../../common/component/loader.module';


@NgModule({
    declarations: [
        ManageProfileComponent
    ],
    imports: [
        CommonModule,
        CardModule,
        PasswordModule,
        ButtonModule,
        FormsModule,
        DropdownModule,
        InputMaskModule,
        LoaderModule,
        ManageProfileRoutingModule
    ],
    providers: [MessageService]
})
export class ManageProfileModule { }
