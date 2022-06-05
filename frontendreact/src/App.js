import React, {useEffect, useState} from 'react';
import './App.css';


function App() {
  const url = 'https://localhost:7094/api/Usuarios'
  const [todos, setTodos]= useState()
  const fetchApi= async() =>{
     const response = await fetch(url)
     const responseJSON = await response.json()
     setTodos(responseJSON)
  }
  useEffect(() => {
    fetchApi()
  }, [])


  return (
    <div className="App">
      Hola Mundo
      <ul>{ !todos ? 'Cargando...' :
      todos.map( (todo,index)=>{
        return <li>{todo.title}</li>
      })
      }
      </ul>
    </div>
  );
}

export default App;
