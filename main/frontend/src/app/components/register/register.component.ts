import { Component, HostBinding, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from "@angular/forms";

import { RegisterService } from "../../services/register.service";
import { HeaderService } from "../../services/header.service";

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {

  active: number = 1;
  @HostBinding('class.is-open')
  showBasicData: boolean = false;
  showAddNotifications: boolean = false;

  constructor(
    public formBuilder: FormBuilder,
    public registerService: RegisterService,
    public headerService: HeaderService
  ) { }

  ngOnInit(): void {
    setTimeout(() => {
      this.headerService.setTitle("Registro del Buscador");
    }, 900);
    this.registerService.change.subscribe((showBasicDataS: boolean) => {
      this.showBasicData = showBasicDataS;
      this.active = 2;
    });
    this.registerService.changeNoti.subscribe((showAddNotificationS: boolean) => {
      this.showAddNotifications = showAddNotificationS;
      this.active = 3;
    });
    this.registerService.disableTab.subscribe((tabs: number[]) => {
      if (tabs.includes(2)) {
        this.showBasicData = false;
      }
      if (tabs.includes(3)) {
        this.showAddNotifications = false;
      }
    });
  }

}
