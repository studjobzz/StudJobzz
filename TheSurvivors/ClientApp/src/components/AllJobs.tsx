import * as React from "react";
import { ListViewModel } from "../view-models/list-jobs";
import { observer, inject } from "mobx-react";
import "../shared/list-all.css";
import JobItem from "./JobItem";
import { ListsStore } from "../store/lists-store";

interface Props {
  listsStore: ListsStore;
}

interface State {
  allLists: ListViewModel;
}

const initialState: State = {
  allLists: {
    id: 1,
    name: "first",
    description: "easy",
    jobs: [
      { id: 1, name: "Software developer", description: "ASP.net" },
      { id: 2, name: "Q&A", description: "Normal" },
      { id: 3, name: "Inginer Constructii", description: "Blocuri" }
    ]
  }
};

@inject("listsStore")
@observer
class AllLists extends React.Component<Props, State> {
  constructor(props: Props) {
    super(props);
    this.state = initialState;
    // this.props.listsStore.loadLists(() => {
    //   this.setState({ allLists: this.props.listsStore.lists });
    // });
  }

  render(): React.ReactNode {
    return (
      <div className="list-items">
        {this.state.allLists.jobs.map((job, index) => {
          return (
            <div key={index}>
              <JobItem job={job} index={index} />
            </div>
          );
        })}
      </div>
    );
  }
}

export default AllLists;
