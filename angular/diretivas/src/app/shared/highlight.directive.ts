import { Directive, HostBinding, HostListener, Input, OnInit } from '@angular/core';

@Directive({
  selector: '[appHighlight]'
})
export class HighlightDirective implements OnInit {

    @HostListener('mouseenter') onMouseOver() {
      this.backgroundColor = this.highlightColor;
    }

    @HostListener('mouseleave') onMouseOLeave() {
      this.backgroundColor =  this.defaultColor;
    }

    @HostBinding('style.backgroundColor') backgroundColor: string = "white";


    @Input() defaultColor = 'white';
    @Input('appHighlight') highlightColor = 'yellow';

    constructor() {

    }

    ngOnInit() {
      this.backgroundColor = this.defaultColor;
    }

}
