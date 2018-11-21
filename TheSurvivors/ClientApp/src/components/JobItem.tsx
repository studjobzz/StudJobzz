import * as React from "react";
import { observer } from "mobx-react";
import { Redirect } from "react-router-dom";
import "../shared/list-all.css";
import { JobViewModel } from "../view-models/job";
import { Link } from "react-router-dom";

export interface Props {
  job: JobViewModel;
  index: number;
}

export interface State {
  redirectTo: string;
}

const initialState: State = {
  redirectTo: ""
};
@observer
class JobItem extends React.Component<Props, State> {
  constructor(props: any) {
    super(props);
    this.state = initialState;
  }

  private handleEditJob() {
    window.location.href = "/jobs/add";
  }

  private handleRedirect(): React.ReactNode {
    if (this.state.redirectTo) {
      return <Redirect to={this.state.redirectTo} />;
    }
    return null;
  }

  render() {
    return (
      this.handleRedirect() || (
        <div className="job-item">
          <img
            src={"images/" + this.props.index + ".jpg"}
            className="job-item-photo"
            onClick={this.handleEditJob.bind(this)}
          />
          <div
            className="summary_field"
            onClick={this.handleEditJob.bind(this)}
          >
            {this.props.job.name}
          </div>
        </div>
      )
    );
  }
}

export default JobItem;
