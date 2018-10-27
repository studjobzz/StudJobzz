import * as React from "react";
import "./App.css";
import rootStore from "./store/root-store";
import { Provider } from "mobx-react";
import AllLists from "./components/AllJobs";

class App extends React.Component {
  public render() {
    return (
      <div className="App">
        <header>
          <img src="images/theme.jpg" className="image" />
        </header>
        <Provider {...rootStore}>
          <React.Fragment>
            <div>
              <h1 className="App-title">Jobs List!</h1>
              <AllLists listsStore={rootStore.listsStore} />
            </div>
          </React.Fragment>
        </Provider>
      </div>
    );
  }
}

export default App;
