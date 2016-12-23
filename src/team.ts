import {autoinject} from 'aurelia-framework';
import {HttpClient} from 'aurelia-fetch-client';
import 'fetch';

@autoinject
export class Users {
  heading = 'Care Application Teamleden';
  teamMembers = [];

  constructor(private http: HttpClient) {
    http.configure(config => {
      config
        .useStandardConfiguration()
          .withBaseUrl('http://localhost:5000/api');
    });
  }

  activate() {
    return this.http.fetch('/teamMember')
      .then(response => response.json())
        .then(data => this.teamMembers = data);
  }
}
