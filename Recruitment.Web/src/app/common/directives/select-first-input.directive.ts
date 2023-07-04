import { Directive, ElementRef, Renderer2 } from '@angular/core';

@Directive({
    selector: 'form[anyNameHere]'
})
export class SelectFirstInputDirective {

    constructor(private _eRef: ElementRef, private _renderer: Renderer2) { }

    private _getInputElement(nativeElement: any): any {
        if (!nativeElement || !nativeElement.children) return undefined;
        if (!nativeElement.children.length && nativeElement.localName === 'input' && !nativeElement.hidden) return nativeElement;

        let input;

        [].slice.call(nativeElement.children).every(c => {
            input = this._getInputElement(c);
            if (input) return false; // break
            return true; // continue!
        });

        return input;
    }

    ngAfterViewInit() {
        let formChildren = [].slice.call(this._eRef.nativeElement.children);

        formChildren.every(child => {
            let input = this._getInputElement(child);

            if (input) {
                this._renderer.selectRootElement.arguments(input, 'focus', []);
                return false; // break!
            }

            return true; // continue!
        });
    }
}