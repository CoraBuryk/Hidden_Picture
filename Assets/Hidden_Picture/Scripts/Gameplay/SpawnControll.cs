using UnityEngine;

namespace Assets.Hidden_Picture.Scripts.Gameplay
{
    public class SpawnControll : MonoBehaviour
    {
        #region Serialized Variables
        [SerializeField] private Transform[] _spawnTransorm;
        [SerializeField] private SpriteRenderer[] _spawnRenderer;
        [SerializeField] private GameObject[] _character;
        [SerializeField] private SpriteRenderer[] _characterSprite;

        [SerializeField] private Transform[] _blackCharacterSpawn;
        [SerializeField] private GameObject[] _blackCharacter;

        [SerializeField] private GameObject[] _clone;
        [SerializeField] private GameObject[] _spawnedObjects;
        #endregion

        private int _randomSpawn;
        private int _randomCharacter;

        private void Start()
        {
            ObjectSpawn();
        }

        public void ObjectSpawn()
        {
            int count = 0;

            while (count < 10)
            {
                _randomSpawn = Random.Range(0, _spawnTransorm.Length);
                _randomCharacter = Random.Range(0, _character.Length);
                switch (_randomCharacter)
                {
                    case 0:
                        _characterSprite[0].sortingOrder = _spawnRenderer[_randomSpawn].sortingOrder;

                        //GameObject si = Instantiate(_blackCharacter[0], _blackCharacterSpawn[count].position, Quaternion.identity);
                        //GameObject clone = Instantiate(_character[0], _spawnTransorm[_randomSpawn].position, Quaternion.identity);

                        //si.transform.parent = clone.transform;
                        //clone.transform.SetParent(_canvas.transform, false);
                        _clone[0] = Instantiate(_blackCharacter[0], _blackCharacterSpawn[count].position, Quaternion.identity);
                        _clone[0].transform.parent = (Instantiate(_character[0], _spawnTransorm[_randomSpawn].position, Quaternion.identity)).transform; 

                        break;
                    case 1:
                        _characterSprite[1].sortingOrder = _spawnRenderer[_randomSpawn].sortingOrder;
                        _clone[1] = Instantiate(_blackCharacter[1], _blackCharacterSpawn[count].position, Quaternion.identity);
                        _clone[1].transform.parent = (Instantiate(_character[1], _spawnTransorm[_randomSpawn].position, Quaternion.identity).transform);
                        break;
                    case 2:
                        _characterSprite[2].sortingOrder = _spawnRenderer[_randomSpawn].sortingOrder;
                        _clone[2] = Instantiate(_blackCharacter[2], _blackCharacterSpawn[count].position, Quaternion.identity);
                        _clone[2].transform.parent = (Instantiate(_character[2], _spawnTransorm[_randomSpawn].position, Quaternion.identity).transform);

                        break;
                    case 3:
                        _characterSprite[3].sortingOrder = _spawnRenderer[_randomSpawn].sortingOrder;                  
                        _clone[3] = Instantiate(_blackCharacter[3], _blackCharacterSpawn[count].position, Quaternion.identity);
                        _clone[3].transform.parent = (Instantiate(_character[3], _spawnTransorm[_randomSpawn].position, Quaternion.identity).transform);

                        break;
                    case 4:
                        _characterSprite[4].sortingOrder = _spawnRenderer[_randomSpawn].sortingOrder;
                        _clone[4] = Instantiate(_blackCharacter[4], _blackCharacterSpawn[count].position, Quaternion.identity);
                        _clone[4].transform.parent = (Instantiate(_character[4], _spawnTransorm[_randomSpawn].position, Quaternion.identity).transform);
                        break;
                    case 5:
                        _characterSprite[5].sortingOrder = _spawnRenderer[_randomSpawn].sortingOrder;
                        _clone[5] = Instantiate(_blackCharacter[5], _blackCharacterSpawn[count].position, Quaternion.identity);
                        _clone[5].transform.parent = (Instantiate(_character[5], _spawnTransorm[_randomSpawn].position, Quaternion.identity).transform);
                        break;
                    case 6:
                        _characterSprite[6].sortingOrder = _spawnRenderer[_randomSpawn].sortingOrder;
                        _clone[6] = Instantiate(_blackCharacter[6], _blackCharacterSpawn[count].position, Quaternion.identity);
                        _clone[6].transform.parent = (Instantiate(_character[6], _spawnTransorm[_randomSpawn].position, Quaternion.identity).transform);
                        break;
                    case 7:
                        _characterSprite[7].sortingOrder = _spawnRenderer[_randomSpawn].sortingOrder;
                        _clone[7] = Instantiate(_blackCharacter[7], _blackCharacterSpawn[count].position, Quaternion.identity);
                        _clone[7].transform.parent = (Instantiate(_character[7], _spawnTransorm[_randomSpawn].position, Quaternion.identity).transform);
                        break;
                    case 8:
                        _characterSprite[8].sortingOrder = _spawnRenderer[_randomSpawn].sortingOrder;
                        _clone[8] = Instantiate(_blackCharacter[8], _blackCharacterSpawn[count].position, Quaternion.identity);
                        _clone[8].transform.parent = (Instantiate(_character[8], _spawnTransorm[_randomSpawn].position, Quaternion.identity).transform);
                        break;
                    case 9:
                        _characterSprite[9].sortingOrder = _spawnRenderer[_randomSpawn].sortingOrder;
                        _clone[9] = Instantiate(_blackCharacter[9], _blackCharacterSpawn[count].position, Quaternion.identity);
                        _clone[9].transform.parent = (Instantiate(_character[9], _spawnTransorm[_randomSpawn].position, Quaternion.identity).transform);
                        break;
                    case 10:
                        _characterSprite[10].sortingOrder = _spawnRenderer[_randomSpawn].sortingOrder;
                        _clone[10] = Instantiate(_blackCharacter[10], _blackCharacterSpawn[count].position, Quaternion.identity);
                        _clone[10].transform.parent = (Instantiate(_character[10], _spawnTransorm[_randomSpawn].position, Quaternion.identity).transform);
                        break;
                    case 11:
                        _characterSprite[11].sortingOrder = _spawnRenderer[_randomSpawn].sortingOrder;
                        _clone[11] = Instantiate(_blackCharacter[11], _blackCharacterSpawn[count].position, Quaternion.identity);
                        _clone[11].transform.parent = (Instantiate(_character[11], _spawnTransorm[_randomSpawn].position, Quaternion.identity).transform);
                        break;
                    case 12:
                        _characterSprite[12].sortingOrder = _spawnRenderer[_randomSpawn].sortingOrder;
                        _clone[12] = Instantiate(_blackCharacter[12], _blackCharacterSpawn[count].position, Quaternion.identity);
                        _clone[12].transform.parent = (Instantiate(_character[12], _spawnTransorm[_randomSpawn].position, Quaternion.identity).transform);
                        break;
                    case 13:
                        _characterSprite[13].sortingOrder = _spawnRenderer[_randomSpawn].sortingOrder;
                        _clone[13] = Instantiate(_blackCharacter[13], _blackCharacterSpawn[count].position, Quaternion.identity);
                        _clone[13].transform.parent = (Instantiate(_character[13], _spawnTransorm[_randomSpawn].position, Quaternion.identity).transform);
                        break;
                    case 14:
                        _characterSprite[14].sortingOrder = _spawnRenderer[_randomSpawn].sortingOrder;
                        _clone[14] = Instantiate(_blackCharacter[14], _blackCharacterSpawn[count].position, Quaternion.identity);
                        _clone[14].transform.parent = (Instantiate(_character[14], _spawnTransorm[_randomSpawn].position, Quaternion.identity).transform);
                        break;
                    case 15:
                        _characterSprite[15].sortingOrder = _spawnRenderer[_randomSpawn].sortingOrder;
                        _clone[15] = Instantiate(_blackCharacter[15], _blackCharacterSpawn[count].position, Quaternion.identity);
                        _clone[15].transform.parent = (Instantiate(_character[15], _spawnTransorm[_randomSpawn].position, Quaternion.identity).transform);
                        break;
                    case 16:
                        _characterSprite[16].sortingOrder = _spawnRenderer[_randomSpawn].sortingOrder;
                        _clone[16] = Instantiate(_blackCharacter[16], _blackCharacterSpawn[count].position, Quaternion.identity);
                        _clone[16].transform.parent = (Instantiate(_character[16], _spawnTransorm[_randomSpawn].position, Quaternion.identity).transform);
                        break;
                    case 17:
                        _characterSprite[17].sortingOrder = _spawnRenderer[_randomSpawn].sortingOrder;
                        _clone[17] = Instantiate(_blackCharacter[17], _blackCharacterSpawn[count].position, Quaternion.identity);
                        _clone[17].transform.parent = (Instantiate(_character[17], _spawnTransorm[_randomSpawn].position, Quaternion.identity).transform);
                        break;
                    case 18:
                        _characterSprite[18].sortingOrder = _spawnRenderer[_randomSpawn].sortingOrder;
                        _clone[18] = Instantiate(_blackCharacter[18], _blackCharacterSpawn[count].position, Quaternion.identity);
                        _clone[18].transform.parent = (Instantiate(_character[18], _spawnTransorm[_randomSpawn].position, Quaternion.identity).transform);
                        break;
                    case 19:
                        _characterSprite[19].sortingOrder = _spawnRenderer[_randomSpawn].sortingOrder;
                        _clone[19] = Instantiate(_blackCharacter[19], _blackCharacterSpawn[count].position, Quaternion.identity);
                        _clone[19].transform.parent = (Instantiate(_character[19], _spawnTransorm[_randomSpawn].position, Quaternion.identity).transform);
                        break;
                    case 20:
                        _characterSprite[20].sortingOrder = _spawnRenderer[_randomSpawn].sortingOrder;
                        _clone[20] = Instantiate(_blackCharacter[20], _blackCharacterSpawn[count].position, Quaternion.identity);
                        _clone[20].transform.parent = (Instantiate(_character[20], _spawnTransorm[_randomSpawn].position, Quaternion.identity).transform);
                        break;
                }
                count++;
            }            
        }

        public void FindObjects()
        {
            _spawnedObjects = GameObject.FindGameObjectsWithTag("Character");
        }

        public void ToDestroy()
        {
            FindObjects();
            for (int i = 0; i < _spawnedObjects.Length; i++)
                Destroy(_spawnedObjects[i]);         
        }

        public void Activate(bool state)
        {
            for (int i = 0; i < _spawnedObjects.Length; i++)
                _spawnedObjects[i].SetActive(state);
        }
    }
}
