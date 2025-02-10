import { Component, OnInit, Input } from '@angular/core';
import { NgbActiveModal, NgbModal } from '@ng-bootstrap/ng-bootstrap';

@Component({
  selector: 'app-modal-error-form',
  templateUrl: './modal-error-form.component.html',
  styleUrls: ['./modal-error-form.component.css']
})
export class ModalErrorFormComponent implements OnInit {

  @Input() public body: string = '';

  constructor(
    public activeModal: NgbActiveModal
  ) { }

  ngOnInit(): void {
  }

}
