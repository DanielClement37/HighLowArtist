import { configureStore, ThunkAction, Action } from '@reduxjs/toolkit';
import scoreReducer from '../features/score/scoreSlice'

export const store = configureStore({
  reducer: {
    score: scoreReducer,
  },
});

export type RootState = ReturnType<typeof store.getState>;
export type AppThunk<ReturnType = void> = ThunkAction<
  ReturnType,
  RootState,
  unknown,
  Action<string>
>;
