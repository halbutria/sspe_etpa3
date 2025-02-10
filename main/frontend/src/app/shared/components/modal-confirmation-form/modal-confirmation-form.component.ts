import { Component, Input, OnInit } from '@angular/core';
import { NgbActiveModal, NgbModal } from '@ng-bootstrap/ng-bootstrap';

@Component({
  selector: 'app-modal-confirmation-form',
  templateUrl: './modal-confirmation-form.component.html',
  styleUrls: ['./modal-confirmation-form.component.css']
})
export class ModalConfirmationFormComponent implements OnInit {

  @Input() public body: string = '';

  constructor(
    public activeModal: NgbActiveModal
  ) { }

  ngOnInit(): void {
  }

}
