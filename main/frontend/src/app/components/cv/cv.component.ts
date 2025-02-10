import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

import { HeaderService } from "../../services/header.service";
import { CvService } from "../../services/cv.service";

@Component({
  selector: 'app-cv',
  templateUrl: './cv.component.html',
  styleUrls: ['./cv.component.css']
})
export class CvComponent implements OnInit {

  constructor(
    public headerService: HeaderService,
    public cvService: CvService,
    private router: Router,
  ) { }

  ngOnInit(): void {
    setTimeout(() => {
      this.headerService.setTitle("Mi hoja de vida");
    }, 900);

    // Consulta la información del storage en el servicio
    // Y si está vacío entonces lo redirige al login
    if (this.cvService.getCiudadano === null) {
      this.router.navigate(['/login']);
    }
  }



}
