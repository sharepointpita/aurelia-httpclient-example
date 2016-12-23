import {Router, RouterConfiguration} from 'aurelia-router'

export class App {
  router: Router;
  
  configureRouter(config: RouterConfiguration, router: Router) {
    config.title = 'Care Tickets';
    config.map([
        { route: ['', 'dashboard'], name: 'dashboard',  moduleId: 'dashboard',      nav: true, title: 'Dashboard' },
        { route: 'team', name: 'team', moduleId: 'team', nav: true, title: 'Team' },
      { route: 'child-router',  name: 'child-router', moduleId: 'child-router', nav: true, title: 'Child Router' }
    ]);

    this.router = router;
  }
}
