import { Component, OnInit } from '@angular/core';

import { HeaderService } from "../services/header.service";

@Component({
  selector: 'app-administrativo',
  templateUrl: './administrativo.component.html',
  styleUrls: ['./administrativo.component.css']
})
export class AdministrativoComponent implements OnInit {

  constructor(
    public headerService: HeaderService,
  ) { }

  ngOnInit(): void {
    setTimeout(() => {
      this.headerService.setTitle("Administrativo");
    }, 900);
  }

}
