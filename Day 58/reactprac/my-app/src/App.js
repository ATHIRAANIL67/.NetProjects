import logo from './logo.svg';
import './App.css';
import Helloworld from './Content/helloworld';
import Car from './Content/car';

function App() {
  return (
    <div className="App">
      <Helloworld></Helloworld>
      <Car color="purple"/>
      {/* <header className="App-header">
        <img src={logo} className="App-logo" alt="logo" />
        <p>
          
          <h1>Hi from Athira</h1>
          <h3>Helloooooooo</h3>
        </p>
        <a
          className="App-link"
          href="https://reactjs.org"
          target="_blank"
          rel="noopener noreferrer"
        >
          Learn React
        </a>
      </header> */}
    </div>
  );
}

export default App;
