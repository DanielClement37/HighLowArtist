import React, { Component } from 'react';
import FastAverageColor from 'fast-average-color';
import axios from 'axios';
import Artist from './Artist/Artist';
import './Game.css';

class Game extends Component {
  constructor(props) {
    super(props);
  }

  state = {
    score: 0,
    artists: [
      {
        externalUrls: {
          spotify: '',
        },
        followers: {
          href: null,
          total: 0,
        },
        genres: [],
        href: '',
        id: '',
        images: [
          {
            height: 640,
            width: 640,
            url: '',
          },
          {
            height: 320,
            width: 320,
            url: '',
          },
          {
            height: 160,
            width: 160,
            url: '',
          },
        ],
        name: '',
        popularity: 0,
        type: 'artist',
        uri: '',
      },
      {
        externalUrls: {
          spotify: '',
        },
        followers: {
          href: null,
          total: 0,
        },
        genres: [],
        href: '',
        id: '',
        images: [
          {
            height: 640,
            width: 640,
            url: '',
          },
          {
            height: 320,
            width: 320,
            url: '',
          },
          {
            height: 160,
            width: 160,
            url: '',
          },
        ],
        name: '',
        popularity: 0,
        type: 'artist',
        uri: '',
      },
    ],
    avgColor: [],
    gameOver: false,
  };

  componentDidMount() {
    this.getArtist();
  }

  getArtist() {
    axios
      .get('http://localhost:5000/api/artists') //TODO: make enviroment variable
      .then((res) => {
        console.log('response', res.data);
        this.setState({ artists: res.data });
        console.log('state:', this.state.artists);
      })
      .catch((e) => {
        console.log('error:', e);
      });
  }

  artistClickHandler = (id, e) => {
    if (id === this.state.artists[0].id) {
      if (this.state.artists[0].popularity > this.state.artists[1].popularity) {
        this.increaseScore();
      } else {
        this.resetScore();
      }
    } else {
      if (this.state.artists[0].popularity < this.state.artists[1].popularity) {
        this.increaseScore();
      } else {
        this.resetScore();
      }
    }
    this.getArtist();
  };

  increaseScore = () => {
    this.setState((state) => {
      // Important: read `state` instead of `this.state` when updating.
      return { score: state.score + 1 };
    });
  };

  resetScore = () => {
    this.setState({ score: 0 });
  };

  render() {
    //TODO: map <Artist /> instead of current implementation
    return (
      <div className='game'>
        <div className='row score'>
          <h3>Score: {this.state.score}</h3>
        </div>
        <div className='row'>
          <div className='column'>
            <Artist
              clicked={this.artistClickHandler}
              imageURL={this.state.artists[0].images[1].url}
              name={this.state.artists[0].name}
              id={this.state.artists[0].id}
            />
          </div>
          <div className='column'>
            <Artist
              clicked={this.artistClickHandler}
              imageURL={this.state.artists[1].images[1].url}
              name={this.state.artists[1].name}
              id={this.state.artists[1].id}
            />
          </div>
        </div>
      </div>
    );
  }
}

export default Game;
