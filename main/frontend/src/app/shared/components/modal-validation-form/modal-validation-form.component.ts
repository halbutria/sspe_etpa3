import { Component, OnInit, Input } from '@angular/core';
import { NgbActiveModal, NgbModal } from '@ng-bootstrap/ng-bootstrap';

@Component({
  selector: 'app-modal-validation-form',
  templateUrl: './modal-validation-form.component.html',
  styleUrls: ['./modal-validation-form.component.css']
})
export class ModalValidationFormComponent implements OnInit {

  @Input() public message: string = '';

  constructor(
    public activeModal: NgbActiveModal
  ) { }

  ngOnInit(): void {
  }

}
