import { Component, OnInit } from '@angular/core';
import { HeaderService } from 'src/app/services/header.service';

@Component({
  selector: 'app-home-empresas',
  templateUrl: './home-empresas.component.html',
  styleUrls: ['./home-empresas.component.scss']
})
export class HomeEmpresasComponent implements OnInit {

  constructor(public headerService:HeaderService) { }

  ngOnInit(): void {
    this.headerService.changeTitle.emit("Empresa");
  }

}
