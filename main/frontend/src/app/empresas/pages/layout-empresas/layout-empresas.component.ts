import { Component, OnInit } from '@angular/core';
import { HeaderService } from 'src/app/services/header.service';

@Component({
  selector: 'app-layout-empresas',
  templateUrl: './layout-empresas.component.html',
  styleUrls: ['./layout-empresas.component.scss']
})
export class LayoutEmpresasComponent implements OnInit {

  constructor(public headerService: HeaderService) { }

  ngOnInit(): void {
    setTimeout(()=>{
      this.headerService.changeTitle.emit("Empresas");
    },1000)

  }

}
