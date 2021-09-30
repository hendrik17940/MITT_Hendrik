import './App.css';
import { BrowserRouter as Router, Switch, Route, Link } from "react-router-dom";
import { Home } from './Home';
import 'bootstrap/dist/css/bootstrap.min.css';
import { NavbarMenu } from './Navbar';
import SkillLevelMaster from './SkillLevelMaster';
import SkillLevel from './SkillMaster';

function App() {
  return (
    <Router>
      <div>
        <NavbarMenu />

        <Switch>
          <Route path="/skillmaster">
            <SkillLevel/>
          </Route>
          <Route path="/skilllevelmaster">
            <SkillLevelMaster/>
          </Route>
        </Switch>

      </div>
    </Router>
  );
}

export default App;
