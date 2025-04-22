import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { PortfolioService } from '../services/portfolio.service';

@Component({
  selector: 'app-portfolio',
  standalone: true,
  imports: [CommonModule],
  template: `
    <ul *ngIf="projects.length">
      <li *ngFor="let project of projects">
        {{ project.title }} ({{ project.tech }})
      </li>
    </ul>
  `,
})
export class PortfolioComponent implements OnInit {
  projects: any[] = [];

  constructor(private portfolioService: PortfolioService) {}

  ngOnInit() {
    this.portfolioService.getProjects().subscribe({
      next: (data) => (this.projects = data),
      error: (err) => console.error('API Error:', err),
    });
  }
}
