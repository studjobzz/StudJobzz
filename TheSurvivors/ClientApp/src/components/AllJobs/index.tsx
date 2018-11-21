import * as React from "react";
import { Route } from "react-router";
import { AllLists } from "./AllJobs";

export default () => {
  return (
    <React.Fragment>
      <Route path="/home" component={AllLists} />
      {/* <Route path="/home" component={AllLists} /> */}
    </React.Fragment>
  );
};
