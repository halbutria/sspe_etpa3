import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { CvService } from 'src/app/services/cv.service';

@Component({
  selector: 'app-header-update',
  templateUrl: './header-update.component.html',
  styleUrls: ['./header-update.component.css']
})
export class HeaderUpdateComponent implements OnInit {

  constructor(public cvService:CvService, private router:Router) { }

  ngOnInit(): void {
  }

  logout() {
    this.cvService.resetCiudadano();
    setTimeout(() => {
      this.router.navigate(['/']);
    }, 500);
  }
}
