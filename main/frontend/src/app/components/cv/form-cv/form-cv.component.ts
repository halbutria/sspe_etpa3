import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from "@angular/forms";
import { TitleStrategy } from '@angular/router';

import { CvService } from "../../../services/cv.service";

@Component({
  selector: 'app-form-cv',
  templateUrl: './form-cv.component.html',
  styleUrls: ['./form-cv.component.css']
})
export class FormCvComponent implements OnInit {

  active: number = 1;

  constructor(
    public formBuilder: FormBuilder,
    public cvService: CvService,
  ) { }

  ngOnInit(): void {
    this.cvService.tabActive.subscribe((tab: number) => {
      this.active = tab;
    });
  }

}
