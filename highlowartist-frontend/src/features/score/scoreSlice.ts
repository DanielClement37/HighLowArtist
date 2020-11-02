import { createSlice, PayloadAction } from '@reduxjs/toolkit';
import { AppThunk, RootState } from '../../app/store';

interface ScoreState {
  value: number;
}

const initialState: ScoreState = {
  value: 0,
};

export const scoreSlice = createSlice({
  name: 'score',
  initialState,
  reducers: {
    increment: state => {
      state.value += 1;
    },
    reset : state =>{
      state.value = 0;
    }
  },
});

export const { increment, reset} = scoreSlice.actions;



// The function below is called a selector and allows us to select a value from
// the state. Selectors can also be defined inline where they're used instead of
// in the slice file. For example: `useSelector((state: RootState) => state.score.value)`
export const selectScore = (state: RootState) => state.score.value;

export default scoreSlice.reducer;
