import * as React from "react";
import { ListViewModel } from "../view-models/list-jobs";
import { observer } from "mobx-react";
import "../shared/list-all.css";
import { JobViewModel } from "../view-models/job";

export interface Props {
  job: JobViewModel;
  index: number;
}

export interface State {}
@observer
class JobItem extends React.Component<Props, State> {
  constructor(props: any) {
    super(props);
  }
  render() {
    return (
      <div className="job-item">
        <img
          src={"images/" + this.props.index + ".jpg"}
          className="job-item-photo"
        />
        <div className="summary_field">{this.props.job.name}</div>
      </div>
    );
  }
}

export default JobItem;
