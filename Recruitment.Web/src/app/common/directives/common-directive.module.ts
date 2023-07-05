import { NgModule } from '@angular/core';
import { LeftTrimmedInput } from './left-trim.directive';
import { InvalidFormDirective } from './invalid-focus.directive';


@NgModule({
    declarations: [LeftTrimmedInput, InvalidFormDirective],    
    exports: [LeftTrimmedInput, InvalidFormDirective]
})
export class CommonDirectiveModule { }
