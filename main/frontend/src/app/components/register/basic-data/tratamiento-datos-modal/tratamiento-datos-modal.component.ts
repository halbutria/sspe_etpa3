import { Component, Input, OnInit } from '@angular/core';
import { NgbActiveModal, NgbModal } from '@ng-bootstrap/ng-bootstrap';

@Component({
  selector: 'app-tratamiento-datos-modal',
  templateUrl: './tratamiento-datos-modal.component.html',
  styleUrls: ['./tratamiento-datos-modal.component.css']
})
export class TratamientoDatosModalComponent implements OnInit {
  @Input() public data:any;
  ocultarfooter = false;
  constructor(
    public activeModal: NgbActiveModal
  ) { }

  ngOnInit(): void {
    console.log(this.data);
    if(this.data?.ocultarfooter===true){
      this.ocultarfooter=true;
    }
  }

}
