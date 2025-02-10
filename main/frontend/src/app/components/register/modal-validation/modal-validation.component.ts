import { Component, Input, OnInit } from '@angular/core';
import { NgbActiveModal, NgbModal } from '@ng-bootstrap/ng-bootstrap';

@Component({
  selector: 'app-modal-validation',
  templateUrl: './modal-validation.component.html',
  styleUrls: ['./modal-validation.component.css']
})
export class ModalValidationComponent implements OnInit {

  @Input() public listErrors: string[] = [];

  constructor(
    public activeModal: NgbActiveModal
  ) { }

  ngOnInit(): void {
  }

}
