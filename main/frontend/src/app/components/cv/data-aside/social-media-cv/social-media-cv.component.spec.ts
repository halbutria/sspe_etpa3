import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SocialMediaCvComponent } from './social-media-cv.component';

describe('SocialMediaCvComponent', () => {
  let component: SocialMediaCvComponent;
  let fixture: ComponentFixture<SocialMediaCvComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SocialMediaCvComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(SocialMediaCvComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
