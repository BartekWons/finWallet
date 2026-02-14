import { Component } from '@angular/core';
import { LeftSidebar } from "./left-sidebar/left-sidebar";
import { CommonModule } from '@angular/common';
import { AccountPanel } from './account-panel/account-panel';

@Component({
  selector: 'app-root',
  imports: [LeftSidebar, CommonModule, AccountPanel],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  activePanel: string = 'overview';

  changePanel(panelName: string) {
    this.activePanel = panelName;
  }
}
