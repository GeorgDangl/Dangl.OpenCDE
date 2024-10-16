import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DocumentDetailComponent } from './document-detail.component';
import { SharedTestingModule } from 'src/app/shared-tesing.module';
import { AppModule } from 'src/app/app.module';

describe('DocumentDetailComponent', () => {
  let component: DocumentDetailComponent;
  let fixture: ComponentFixture<DocumentDetailComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [DocumentDetailComponent],
      imports: [SharedTestingModule, AppModule],
    }).compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DocumentDetailComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
