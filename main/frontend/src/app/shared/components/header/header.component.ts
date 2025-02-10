import { Component, HostBinding, OnInit } from '@angular/core';

import { HeaderService } from "../../../services/header.service";
import { TratamientoDatosModalComponent } from '../../../components/register/basic-data/tratamiento-datos-modal/tratamiento-datos-modal.component';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent implements OnInit {

  @HostBinding('class.is-open')
  title: string = '';

  constructor(public headerService: HeaderService,private modalService: NgbModal) { }

  ngOnInit(): void {
    this.headerService.changeTitle.subscribe((title: string) => {
      this.title = title;
    });
  }

  enConstruccion($event:any){
    $event.preventDefault();    
    alert('En construcción!!')
  }

  noDisponible($event:any){
    $event.preventDefault();    
    alert('Servicio no disponible!!')
  }

  toggleCheckbox(e: any, control: string) {
    e.preventDefault();    
    const modalTratamientos = this.modalService.open(TratamientoDatosModalComponent, {
      size: 'md', backdrop: 'static', animation: true
    });
    modalTratamientos.componentInstance.data={"ocultarfooter":true}
    modalTratamientos.result.then(response => {
     
    });
  }

}
