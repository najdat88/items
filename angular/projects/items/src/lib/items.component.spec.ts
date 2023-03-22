import { ComponentFixture, TestBed, waitForAsync } from '@angular/core/testing';
import { ItemsComponent } from './components/items.component';
import { ItemsService } from '@najd.Md/items';
import { of } from 'rxjs';

describe('ItemsComponent', () => {
  let component: ItemsComponent;
  let fixture: ComponentFixture<ItemsComponent>;
  const mockItemsService = jasmine.createSpyObj('ItemsService', {
    sample: of([]),
  });
  beforeEach(waitForAsync(() => {
    TestBed.configureTestingModule({
      declarations: [ItemsComponent],
      providers: [
        {
          provide: ItemsService,
          useValue: mockItemsService,
        },
      ],
    }).compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ItemsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
