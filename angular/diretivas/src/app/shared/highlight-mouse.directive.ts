import { Directive, HostListener, ElementRef, Renderer2, HostBinding } from '@angular/core';

@Directive({
  selector: '[appHighlightMouse]'
})
export class HighlightMouseDirective {

  // @HostListener('mouseenter') onMouseOver() {
  //   // this._renderer.setStyle(
  //   //   this._elementRef.nativeElement,
  //   //   'background-color',
  //   //   'yellow'
  //   // );
  //   this.backgroundColor = 'yellow';
  // }

  // @HostListener('mouseleave') onMouseOLeave() {
  //   // this._renderer.setStyle(
  //   //   this._elementRef.nativeElement,
  //   //   'background-color',
  //   //   'white'
  //   // );
  //   this.backgroundColor = 'white';
  // }

  // // @HostBinding('style.backgroundColor') backgroundColor: string;
  // @HostBinding('style.backgroundColor') get setColor() {

  //   return this.backgroundColor;
  // }
  // constructor(private _elementRef: ElementRef, private _renderer: Renderer2) {


  // }

}
