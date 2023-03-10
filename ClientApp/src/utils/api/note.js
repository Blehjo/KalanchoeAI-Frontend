import axios from "axios";

const api = "https://kalanchoeai-server.azurewebsites.net/api/note";

const headers = {
  'Accept': 'application/json',
  'Content-Type': 'application/json' 
}

export async function getSingleNote(noteId) {
  return await axios({
    method: 'get',
    url: `${api}/${noteId}`,
    config: headers,
    withCredentials: true
  })
}

export async function getPanelNotes(panelId) {
  return await axios({
    method: 'get',
    url: `${api}/user/${panelId}`,
    config: headers,
    withCredentials: true
  })
}

export async function getNotes() {
  return await axios({
    method: 'get',
    url: api,
    config: headers,
    withCredentials: true
  });
}

export async function addNote({value, id}) {
  return await axios({
    method: 'post',
    url: api, 
    data: {
      noteValue: value,
      panelId: id
    },
    config: headers,
    withCredentials: true
  });
}

export async function editNote(note) {
  return await axios({
    method: 'put',
    url: `${api}/${note.id}`, 
    data: note, 
    config: headers,
    withCredentials: true
  });
}

export async function deleteNote(noteId) {
  return await axios({
    method: 'delete',
    url: `${api}/${noteId}`,
    config: headers,
    withCredentials: true
  });
}