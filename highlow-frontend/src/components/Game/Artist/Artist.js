import React from 'react';
import FastAverageColor from 'fast-average-color';
import './Artist.css';

const Artist = (props) => {
  return (
    <div>
      <img
        onClick={(e) => {
          props.clicked(props.id, e);
        }}
        src={props.imageURL}
        alt='artist'
        className='artist'
      />
      <p>{props.name}</p>
    </div>
  );
};

export default Artist;
