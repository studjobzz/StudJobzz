import * as React from "react";
import "./App.css";
import rootStore from "./store/root-store";
import { Provider } from "mobx-react";
import { BrowserRouter as Router } from "react-router-dom";
import AllLists from "./components/AllJobs/AllJobs";
import JobFormRoute from "./components/Job";
import AllListsRoute from "./components/AllJobs";

class App extends React.Component {
  public render() {
    return (
      <div className="App">
        <Provider {...rootStore}>
          <React.Fragment>
            <Router>
              <React.Fragment>
                <JobFormRoute />
                <AllListsRoute />
              </React.Fragment>
            </Router>
          </React.Fragment>
        </Provider>
      </div>
    );
  }
}

export default App;
