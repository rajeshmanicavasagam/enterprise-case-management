import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CaseService } from '../case.service';

@Component({
  selector: 'app-case-list',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './case-list.component.html'
})
export class CaseListComponent {
  cases = this.caseService.getCases();

  constructor(private caseService: CaseService) {}
}
