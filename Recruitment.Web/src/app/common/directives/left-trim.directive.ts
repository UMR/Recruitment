import { Directive, HostBinding, HostListener } from '@angular/core';
import { NgModel, FormControlName } from '@angular/forms';

@Directive({
    selector: '[lefttrimmed]',
    providers: [NgModel, FormControlName]
})
export class LeftTrimmedInput {

    constructor(private model: NgModel, private formControlName: FormControlName) { }

    @HostListener("keyup", ["$event.target.value"])

    onInputChange(value: string) {

        let leftTrimmedValue = '';

        if (this.model && value && value.trim().length === 0) {
            this.model.control.setErrors({ 'invalid': true });
            this.model.viewToModelUpdate(leftTrimmedValue);
            this.model.valueAccessor?.writeValue(leftTrimmedValue);
        }

        if (this.formControlName.control && value && value.trim().length === 0) {
            this.formControlName.control.setErrors({ 'invalid': true });
            this.formControlName.viewToModelUpdate(leftTrimmedValue);
            this.formControlName.valueAccessor?.writeValue(leftTrimmedValue);
            this.formControlName.control.parent?.get('' + this.formControlName.name + '')?.setValue(leftTrimmedValue);
        }
    }
}