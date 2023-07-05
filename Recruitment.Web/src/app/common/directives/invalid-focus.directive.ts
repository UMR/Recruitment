import { Directive, HostListener, ElementRef, Input } from '@angular/core';

@Directive({
    selector: '[focusInvalidInput]'
})
export class InvalidFormDirective {    

    constructor(private el: ElementRef) { }

    @HostListener('submit', ['$event'])
    onSubmit() {
        const invalidControl = this.el.nativeElement.querySelector('.ng-invalid');

        console.log(invalidControl);

        if (invalidControl) {
            invalidControl.focus();
        }
    }
}