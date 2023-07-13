import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PostCodeComponent } from './post-code.component';

describe('PostCodeComponent', () => {
  let component: PostCodeComponent;
  let fixture: ComponentFixture<PostCodeComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [PostCodeComponent]
    });
    fixture = TestBed.createComponent(PostCodeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
