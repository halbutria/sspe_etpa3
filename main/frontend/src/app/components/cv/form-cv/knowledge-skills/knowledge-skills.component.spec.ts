import { ComponentFixture, TestBed } from '@angular/core/testing';

import { KnowledgeSkillsComponent } from './knowledge-skills.component';

describe('KnowledgeSkillsComponent', () => {
  let component: KnowledgeSkillsComponent;
  let fixture: ComponentFixture<KnowledgeSkillsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ KnowledgeSkillsComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(KnowledgeSkillsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
