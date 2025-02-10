import { Component, OnInit, Input } from '@angular/core';
import { NgbActiveModal, NgbModal } from '@ng-bootstrap/ng-bootstrap';

@Component({
  selector: 'app-modal-success-form',
  templateUrl: './modal-success-form.component.html',
  styleUrls: ['./modal-success-form.component.css']
})
export class ModalSuccessFormComponent implements OnInit {

  @Input() public body: string = '';

  constructor(
    public activeModal: NgbActiveModal
  ) { }

  ngOnInit(): void {
  }

}
