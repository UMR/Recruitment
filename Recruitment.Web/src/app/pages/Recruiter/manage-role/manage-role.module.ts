import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ManageRoleComponent } from './manage-role.component';
import { ManageRoleRoutingModule } from './manage-role-routing.module';
import { LoaderModule } from '../../../common/component/loader.module';



@NgModule({
    declarations: [
        ManageRoleComponent
    ],
    imports: [
        CommonModule,
        ManageRoleRoutingModule,
        LoaderModule
    ]
})
export class ManageRoleModule { }
