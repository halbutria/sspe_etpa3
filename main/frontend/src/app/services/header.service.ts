import { EventEmitter, Injectable, Output } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class HeaderService {

  title: string = "";

  @Output() changeTitle: EventEmitter<string> = new EventEmitter<string>();

  constructor() { }

  public setTitle(titleStr: string) {
    this.title = titleStr;
    this.changeTitle.emit(this.title);
  }
  public getTitle(): string {
    return this.title;
  }
}
