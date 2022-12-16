import React from 'react';
import './App.css';

class App extends React.Component{
  constructor() {
    super();
    this.state = {
      title: "Daftar Mata Kuliah Teknik Informatika UNRI",
      matkuls: ["Dasar pemograman", "Pengantar Teknik"],
      matkulInput: "",
      showMassage: false,
    };
  }

  handleMatkulInput(evt){

    this.setState({
      matkulInput: evt.target.value,
      showMassage: false,
    });
  }

  handleSimpan(){
    const newMatkuls = this.state.matkuls.concat(this.state.matkulInput);
    this.setState({
      matkuls: newMatkuls,
      matkulInput: "",
    })
  }
handleHapus(matkulHapus){
  const newMatkuls = this.state.matkuls.filter((matkul) => matkul !== matkulHapus);
  this.setState({
    matkuls: newMatkuls,
    showMassage: true,
  });
}


  render(){
    return (
      <div className='App'>
        <div>

          <h1>{this.state.title}</h1>

          <hr />
          <input type="text"
                 value={this.state.matkulInput}
                 onChange={(evt) => this.handleMatkulInput(evt)}/>
          <button onClick={() => this.handleSimpan()}>Tambah Mata Kuliah</button>
      </div>
      {this.state.matkuls.map((matkul, idx) => {
        return (
          <div key={idx}>
            <p>{matkul}
            <button onClick={() => this.handleHapus(matkul)}>Hapus</button>
            {this.state.showMassage && <p> Matkul berhasil dihapus</p>}
            </p>
          </div>
        ); 
      })}
      </div>
    );
  }
}

export default App;