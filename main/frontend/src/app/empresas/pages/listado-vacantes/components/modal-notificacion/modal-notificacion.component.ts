import { Component, Input, OnInit } from '@angular/core';
import { NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';

@Component({
  selector: 'app-modal-notificacion',
  templateUrl: './modal-notificacion.component.html',
  styleUrls: ['./modal-notificacion.component.css']
})
export class ModalNotificacionComponent implements OnInit {
  @Input() fromParent: any;
  public MensajeNotificacion:string = "";
  public TipoNotificacion:string = "";
  constructor(public modalActiveService: NgbActiveModal,) { }

  ngOnInit(): void {
    this.TipoNotificacion = this.fromParent?.Tipo;
    this.MensajeNotificacion = this.fromParent?.Mensaje;
  }

  closeModal() {
    this.modalActiveService.close(null);
  }
}
