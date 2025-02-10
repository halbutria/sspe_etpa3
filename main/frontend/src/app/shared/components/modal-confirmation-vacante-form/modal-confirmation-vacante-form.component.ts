// import { Component, OnInit } from '@angular/core';

// @Component({
//   selector: 'app-modal-confirmation-vacante-form',
//   templateUrl: './modal-confirmation-vacante-form.component.html',
//   styleUrls: ['./modal-confirmation-vacante-form.component.css']
// })
// export class ModalConfirmationVacanteFormComponent implements OnInit {

//   constructor() { }

//   ngOnInit(): void {
//   }

// }



import { Component, Input, OnInit } from '@angular/core';
import { NgbActiveModal, NgbModal } from '@ng-bootstrap/ng-bootstrap';

@Component({
  selector: 'app-modal-confirmation-vacante-form',
   templateUrl: './modal-confirmation-vacante-form.component.html',
  styleUrls: ['./modal-confirmation-vacante-form.component.css']
})
export class ModalConfirmationVacanteFormComponent implements OnInit {

  @Input() public body: string = '';

  constructor(
    public activeModal: NgbActiveModal
  ) { }

  ngOnInit(): void {
  }

}