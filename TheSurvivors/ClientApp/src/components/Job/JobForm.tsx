import * as React from "react";
import { observer, inject } from "mobx-react";
import JobItem from "../JobItem";
import { JobViewModel } from "src/view-models/job";

interface Props {
  jobSelected: JobViewModel;
}

interface State {}

@observer
export class JobForm extends React.Component<Props, State> {
  constructor(props: Props) {
    super(props);
  }

  render() {
    return (
      <div>
        <p>Alex</p>
        <p>{"Alex"}</p>
      </div>
    );
  }
}

export default JobForm;