import { StyleSheet } from 'react-native';

const styles = StyleSheet.create({
  container: {
    flex: 1,
    alignItems: 'center',
    justifyContent: 'center',
    flexGrow: 1,
    flexDirection: 'column',
    padding: 10,
  },

  topBar: {
    flexDirection: 'row',
    justifyContent: 'space-around',
    width: '100%',
  },

  background: {
    flexGrow: 1,
    flexShrink: 1,
    backgroundColor: '#e0e0f0',
  },

  button: {
    backgroundColor: '#c0c0c0',
    borderWidth: 2,
    borderRadius: 5,
    borderColor: '#606060',
    padding: 3,
    paddingHorizontal: 5,
    margin: 5,
    width: '100%',
  },

  textButton: {
    textAlign: 'center',
  },

  presed: {
    backgroundColor: '#c0c0f0',
    borderRadius: 2,
    borderColor: '#606060',
  },

  header: {
    fontSize: 24,
    fontWeight: 'bold',
  },

  text: {
    fontSize: 26,
  },

  smallText: {
    fontSize: 18,
  },

  input: {
    fontSize: 26,
    borderBottomWidth: 2,
    borderBottomColor: '#404040',
    borderRadius: 2,
  },

  icon: {
    margin: 2,
  },

  smallIcon: {
    width: 12,
    resizeMode: 'contain',
    margin: 2,
  },

  mediumIcon: {
    width: 18,
    resizeMode: 'contain',
  },

  bigIcon: {
    width: 36,
    height: 36,
  },

  gigaIcon: {
    width: 54,
    height: 54,
  },

  list: {
    width: '100%',
  },

  listItem: {
    flex: 1,
    alignItems: 'center',
    justifyContent: 'center',
    flexDirection: 'row',
    flexGrow: 1,
    width: '100%',
    borderColor: '#A0A0A0',
    borderWidth: 2,
    borderRadius: 8,
    backgroundColor: '#D0D0D0',
    marginVertical: 2,
    paddingVertical: 1,
    paddingHorizontal: 6,
  },

  border: {
    borderColor: 'red',
    borderWidth: 2,
  },

  floatTopLeft: {
    position: 'absolute',
    right: 0,
    bottom: 0,
    zIndex: 2,
    minWidth: 30,
    minHeight: 30,
    margin: 5,
  },

  field: {
    width: '100%',
    borderColor: '#808080',
    borderWidth: 2,
    borderRadius: 3,
    margin: 4,
    padding: 5,
  },

  label: {
    color: '#606060',
    fontSize: 20,
    fontWeight: 'bold',
  },

  sameLine: {
    display: 'flex',
    flexDirection: 'row',
    alignItems: 'center',
    gap: 10,
  },

  disabled:  {
    color: '#808080',
  },

  prayer:  {
    fontSize: 22,
  },

  prayerTitle:  {
    fontSize: 28,
    fontWeight: 'bold',
    marginTop: 8,
    marginBottom: 15,
  },
});

export default styles;
